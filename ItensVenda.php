<?php
$action = 'recuperar';
require 'php_pdo.php';

?>
<!DOCTYPE html>

<html>

<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="./css/style.css" type="text/css" />

    <script>
        function removerItem(codigo) {
            location.href = "php_pdo.php?page=itens_venda&action=remover&codigo=" + codigo;
        }

        function addVenda(codigo) {
            location.href = "php_pdo.php?page=vendas&action=inserir&codigo_venda=" + codigo;
        }
    </script>
</head>

<body>

    <div class="padding-20 container-title">
        <h1>
            ITENS / VENDAS
        </h1>
    </div>

    <div class="table-client-view">


        <a href="index.php?page=vendas&action=recuperarVendas" class="registros">Página Inicial</a>
        <a href="InserirVenda.php" class="registros">Novo registro</a>
        <table class="table">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Produto</th>
                    <th>Valor unitário</th>
                    <th>Quantidade</th>
                    <th>Cliente</th>
                    <th>Valor total</th>

                </tr>
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
                                <?php echo $item->valor_unitario ?>
                            </td>
                            <td>
                                <?php echo $item->quantidade ?>
                            </td>

                            <td>
                                <?php echo $item->nome ?>
                            </td>
                            <td>
                                <?php echo ($item->quantidade * $item->valor_unitario) ?>
                            </td>
                            <td align="center">
                                <button type="submit" onclick="removerItem(<?= $item->codigo ?>)" class="table-button">Remover</button>
                                <a style="margin-left: auto; margin-right: auto;" class="table-button" href="EditarVenda.php?page=itens_venda&action=recuperar&codigo=<?= $item->codigo ?>">Editar</a>
                            </td>
                            <td>
                                <button class="table-button" style="background: green;color: #fff;" type="submit" onclick="addVenda(<?= $item->codigo ?>)">Confirmar</a>
                            </td>
                        </tr>
                    <?php } ?> <?php } else { ?>
                    <div style=" margin-top: 40px;color: red;">
                        <h3>Sem cadastro de dados</h3>
                    </div>
                <?php } ?>

            </tbody>
        </table>
</body>

</html>