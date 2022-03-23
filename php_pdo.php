<?php
error_reporting(E_ALL ^ E_WARNING);
date_default_timezone_set('America/Sao_Paulo');


$connectionString = "odbc:Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:\\xampp\\htdocs\\AStore\\astore_database.accdb;Uid=;Pwd=;";

$database = "astore_database.accdb";

if (!file_exists($database)) {
    echo 'Algo está errado <br>';
}
try {
    $database = new PDO($connectionString);
} catch (PDOException $pe) {
    echo 'ERROR <br><br>' . $pe->getMessage() . '<br>';
}

$action = isset($_GET['action']) ? $_GET['action'] : $action;
$itens = array();

$clientes = array();
$query = "SELECT codigo, nome FROM tbdCliente";
$stmt = $database->prepare($query);
$stmt->execute();
$clientes = $stmt->fetchAll(PDO::FETCH_OBJ);

$produto = [];
$query = "SELECT codigo, produto FROM tbdProduto";
$stmt = $database->prepare($query);
$stmt->execute();
$produto = $stmt->fetchAll(PDO::FETCH_OBJ);

// echo 'GET ACTION PDO';
// echo '<pre>';
// print_r($_GET);
// echo '</pre>';

// echo '<hr>';

// echo 'GET POST PDO';
// echo '<pre>';
// print_r($_POST);
// echo '</pre>';


if ($_GET['page'] == 'produto') {
    if ($action == 'inserir') {
        $query = "INSERT INTO tbdProduto (produto, valor_unitario, descricao) VALUES(:produto, :valor_unitario, :descricao)";
        $stmt = $database->prepare($query);
        $stmt->bindValue(':produto', $_POST['produto']);
        $stmt->bindValue(':valor_unitario', str_replace('.', ',', $_POST['valor_unitario']));
        $stmt->bindValue(':descricao', $_POST['descricao']);
        $stmt->execute();
        header('location: Produtos.php?page=produto');
    } else if ($action == 'remover') {
        $query = 'DELETE FROM tbdProduto WHERE codigo = :codigo';
        $stmt = $database->prepare($query);
        $stmt->bindValue(':codigo', $_GET['codigo']);
        $stmt->execute();
        header('location: Produtos.php?page=produto');
    } else if ($action == 'recuperar') {
        $query = "SELECT codigo, produto, descricao, valor_unitario FROM tbdProduto";
        $stmt = $database->prepare($query);
        $stmt->execute();
        $itens = $stmt->fetchAll(PDO::FETCH_OBJ);
    } else if ($action == 'editar') {
        if (isset($_GET['codigo'])) {
            $query = 'UPDATE tbdProduto SET produto = :produto, descricao = :descricao, valor_unitario = :valor_unitario WHERE codigo = :codigo';
            $stmt = $database->prepare($query);
            $stmt->bindValue(':codigo', $_GET['codigo']);
            $stmt->bindValue(':produto', $_POST['produto']);
            $stmt->bindValue(':valor_unitario', $_POST['valor_unitario']);
            $stmt->bindValue(':descricao', $_POST['descricao']);
            $stmt->execute();
            header('location: Produtos.php?page=produto');
        }
    }
} else if ($_GET['page'] == 'itens_venda') {
    if ($action == 'inserir') {
        $query = "INSERT INTO tbdVendaItens(codigo_cliente, codigo_produto, quantidade) VALUES(:codigo_cliente, :codigo_produto, :quantidade)";
        $stmt = $database->prepare($query);
        $stmt->bindValue(':codigo_cliente', $_POST['codigo_cliente']);
        $stmt->bindValue(':codigo_produto', $_POST['codigo_produto']);
        $stmt->bindValue(':quantidade', $_POST['quantidade']);
        $stmt->execute();
        // Insere nos itens;
        header('location: ItensVenda.php?page=itens_venda');
    } else if ($action == 'recuperar') {
        $query = "SELECT tv.codigo, tp.produto, tp.valor_unitario, tv.quantidade, tc.nome
         FROM ((tbdVendaItens as tv 
         INNER JOIN tbdCliente as tc ON tc.codigo = tv.codigo_cliente) 
         INNER JOIN tbdProduto as tp ON tp.codigo = tv.codigo_produto)";
        $stmt = $database->prepare($query);
        $stmt->execute();
        $itens = $stmt->fetchAll(PDO::FETCH_OBJ);
    } else if ($action == 'remover') {
        if (isset($_GET['codigo'])) {
            $query = 'DELETE FROM tbdVendaItens WHERE codigo = :codigo';
            $stmt = $database->prepare($query);
            $stmt->bindValue(':codigo', $_GET['codigo']);
            $stmt->execute();
            $query2 = 'DELETE FROM tbdVenda WHERE codigo_venda = :codigo';
            $stmt2 = $database->prepare($query2);
            $stmt2->bindValue(':codigo', $_GET['codigo']);
            $stmt2->execute();

            header('location: ItensVenda.php?page=itens_venda');
        }
    } else if ($action == 'editar') {
        if (isset($_GET['codigo'])) {
            $query = 'UPDATE tbdVendaItens SET codigo_cliente = :codigo_cliente, codigo_produto = :codigo_produto, quantidade = :quantidade WHERE codigo = :codigo';
            $stmt = $database->prepare($query);
            $stmt->bindvalue(':codigo', $_GET['codigo']);
            $stmt->bindvalue(':codigo_cliente', $_POST['codigo_cliente']);
            $stmt->bindvalue(':codigo_produto', $_POST['codigo_produto']);
            $stmt->bindvalue(':quantidade', $_POST['quantidade']);
            $stmt->execute();
            header('location: ItensVenda.php?page=itens_venda');
        }
    }
} else if ($_GET['page'] == 'vendas') {
    if ($action == 'inserir') {
        $query2 = "SELECT codigo_venda FROM tbdVenda";
        $stmt2 = $database->prepare($query2);
        $stmt2->execute();
        $teste = $stmt2->fetchAll(PDO::FETCH_OBJ);

        foreach ($teste as $index => $item) {
            if ($item->codigo_venda == $_GET['codigo_venda']) {
                header('location: index.php?page=vendas&success=0');
            }
        }
        $query = "INSERT INTO tbdVenda(data_venda, codigo_venda)VALUES(Date(), :codigo_venda);";
        $stmt = $database->prepare($query);
        $stmt->bindValue(':codigo_venda', $_GET['codigo_venda']);
        $stmt->execute();
        echo '<div style="background:green;"><h3 style="color: white;text-align:center;">Adicionado com sucesso</h3></div>';
        header('location: index.php?page=vendas&success=1');

    } else if ($action == 'recuperarVendas') {
        $query = "SELECT tbv.codigo, tbv.data_venda,tbc.nome FROM ((tbdVenda as tbv 
        INNER JOIN tbdVendaItens as tbvi ON tbvi.codigo = tbv.codigo_venda) 
        INNER JOIN tbdCliente as tbc ON tbvi.codigo_cliente = tbc.codigo)";
        $stmt = $database->prepare($query);
        $stmt->execute();
        $itens = $stmt->fetchAll(PDO::FETCH_OBJ);
    }
} else if ($_GET['page'] == 'funcionario') {
    if ($action == 'inserir') {
        $query = 'INSERT INTO tbdFuncionarios (nome) VALUES(:nome)';
        $stmt = $database->prepare($query);
        $stmt->bindValue(':nome', $_POST['nome']);
        $stmt->execute();
        header('location: Funcionario.php?page=funcionario');
    } else if ($action == 'recuperar') {
        $query = 'SELECT codigo, nome FROM tbdFuncionarios';
        $stmt = $database->prepare($query);
        $stmt->execute();
        $itens = $stmt->fetchAll(PDO::FETCH_OBJ);
    } else if ($action == 'remover') {
        $query = 'DELETE FROM tbdFuncionarios WHERE codigo = :codigo';
        $stmt = $database->prepare($query);
        $stmt->bindValue(':codigo', $_GET['codigo']);
        $stmt->execute();
        header('location: Funcionario.php?page=funcionario');
    }
}
