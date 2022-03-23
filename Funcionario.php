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
            location.href = "php_pdo.php?page=funcionario&action=remover&codigo=" + codigo;
        }
    </script>
</head>

<body>
    <div class="padding-20 container-title">
        <h1>
            FUNCIONÁRIOS
        </h1>
    </div>

    <div class="table-client-view">
        <div>
            <form action="php_pdo.php?page=funcionario&action=inserir" method="post" accept-charset="UTF-8">
                <input required="required" placeholder="Nome do funcionário" name="nome" type="text" class="border-produto form-control-itens">
                <button type="submit" class="style-button" name="enviar" style="margin-left: 5px;">SALVAR</button>
            </form>
        </div>
    </div>

    <div class="table-client-view">
        <a href="index.php?page=vendas&action=recuperarVendas" class="registros">Página Inicial</a>

        <table class="table">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
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
                                <?php echo $item->nome ?>
                            </td>

                            <td align="center">
                                <button type="submit" onclick="removerItem(<?= $item->codigo ?>)" class="table-button">Remover</button>
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