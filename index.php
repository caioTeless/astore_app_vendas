<?php
$action = 'recuperarVendas';
require 'php_pdo.php';
$total_product = count($produto);
$content_buttons = ["index.php?page=vendas", "ItensVenda.php?page=itens_venda"];

?>

<!DOCTYPE html>

<html>

<head>
    <title>AStore</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="./css/style.css" type="text/css" />
    
</head>

<body>

    <?php if ($_GET['success'] == '0') { ?>
        <div style="background: red;color:#fff;text-align:center;">
            <h3>Item já foi adicionado</h3>
        </div>
    <?php } else if($_GET['success'] == 1){ ?>
        <div style="background: green;color:#fff;text-align:center;">
            <h3>Adicionado com sucesso</h3>
        </div>
    <?php } ?>

    <div class="padding-20 container-title">
        <h1>
            Controle suas vendas
        </h1>
    </div>
    <div class="margin-30 container-control">
        <ul class="menu-side">
            <li>
                <a class="effect" href="<?php echo $total_product > 0 ?  $content_buttons[0] : '#';?>">Vendas</a>
            </li>
            <li>
                <a class="effect" href="<?php echo $total_product > 0 ?  $content_buttons[1] : '#';?>">Itens vendas</a>
            </li>
            <li>
                <a class="effect" href="Produtos.php?page=produto">Produtos</a>
            </li>
            <li>
                <a class="effect" href="Funcionario.php?page=funcionario" style="border-right: none;">Funcionários</a>
            </li>
        </ul>
        <div class="table-div">
            <table class="table">
                <thead>
                    <tr>
                        <th>Número da Venda</th>
                        <th>Data da Venda</th>
                        <th>Cliente</th>
                    </tr>
                    <thead>
                    <tbody>
                        <?php foreach ($itens as $index => $vendas) { ?>
                            <tr>
                                <td>
                                    <a href="php_pdo.php?page=itens_venda&action=remover&codigo=<?= $vendas->codigo_venda ?>" style="color:black;"><?= $vendas->codigo ?></a>
                                </td>
                                <td>
                                    <a href="#" style="color:black;"><?= $vendas->data_venda ?></a>
                                </td>
                                <td>
                                    <a href="#" style="color:black;"><?= $vendas->nome ?></a>
                                </td>

                            <?php } ?>
                            </tr>
                    </tbody>

            </table>
        </div>
        <br>
        <br>
    </div>

</body>

</html>