<?php
require 'php_pdo.php';
$action = 'recuperar';

?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="./css/style.css" type="text/css" />
</head>

<body>
    <div class="padding-20 container-title">
        <h1>
            INSERIR VENDA
        </h1>
    </div>

    <!-- Código / Descrição / Produto / Quantidade / Valor / Unitário / Valor Total -->

    <div class="table-client-view">
        <div>
            <form action="php_pdo.php?page=itens_venda&action=inserir" method="post" accept-charset="UTF-8">
                <label class="label-control">Cliente</label> <br>
                <select name="codigo_cliente" class="form-control-itens border-produto" style="width: 220px;height:50px;">
                    <?php foreach ($clientes as $index => $cliente) { ?>
                        <option value="<?= $cliente->codigo ?>"><?= $cliente->nome ?></option>
                    <?php } ?>
                </select><br>

                <label class="label-control">Produto</label><br>
                <select name="codigo_produto" class="form-control-itens border-produto" style="width: 220px;height:50px;">
                    <?php foreach ($produto as $index => $item) { ?>
                        <option value="<?= $item->codigo ?>"><?= $item->produto ?></option>
                    <?php } ?>
                </select><br>
                <label class="label-control">Quantidade</label>
                <input required="required" placeholder="Insira uma quantidade" name="quantidade" type="number" class="border-produto form-control-itens">
                <button type="submit" class="style-button" name="enviar">INSERIR</button>
                <a href="ItensVenda.php" style="color: black;margin-left: 8px;">VOLTAR</a>
            </form>
        </div>
    </div>

</body>

</html>