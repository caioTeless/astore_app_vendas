<?php
$action = 'recuperar';
require 'php_pdo.php';

?>
<!DOCTYPE html>

<html>

<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="./css/style.css" type="text/css" />

    <style>
       
    </style>

    <script>
        function removerItem(codigo) {
            location.href = "php_pdo.php?page=produto&action=remover&codigo=" + codigo;
        }
    </script>
</head>

<body>
    <div class="padding-20 container-title">
        <h1>
            PRODUTOS
        </h1>
    </div>

    <div class="table-client-view">
        <a href="index.php?page=vendas&action=recuperarVendas" class="registros">Página Inicial</a>
        <a href="InserirProduto.php" class="registros">Novo Registro</a>

        <table class="table">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Produto</th>
                    <th>Descrição</th>
                    <th>Valor unitário</th>
                <tr>
            </thead>
            <tbody>
                <?php if (count($itens) != 0) {
                    foreach ($itens as $index => $item) { ?>
                        <tr>
                            <td>
                                <?php echo $item->codigo ?>
                            </td>
                            <td>
                                <?php echo $item->produto ?>
                            </td>
                            <td>
                                <?php echo $item->descricao ?>
                            </td>
                            <td>
                                <?php echo $item->valor_unitario ?>
                            </td>
                            <td align="center">
                                <button type="submit" onclick="removerItem(<?= $item->codigo ?>)" class="table-button">Remover</button>
                                <a style="margin-left: auto; margin-right: auto;" class="table-button" href="EditarProduto.php?page=produto&action=recuperar&codigo=<?= $item->codigo ?>">Editar</a>
                            </td>
                        </tr>
                    <?php } ?>
                <?php  } else { ?>
                    <div style="margin-top: 40px;color: red;"> 
                        <h3>Sem cadastro de dados</h3>
                    </div>
                <?php } ?>
            </tbody>
        </table>
    </div>
</body>

</html>