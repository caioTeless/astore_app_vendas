<?php

$action = 'recuperar';
require 'php_pdo.php';

$itensEdit = array();

foreach ($itens as $index => $item) {
    if ($item->codigo == $_GET['codigo']) {
        $itensEdit = $item;
    }
}
?>
<!DOCTYPE html>

<html>

<head>
    <meta charset="UTF-8" />

    <link rel="stylesheet" href="./css/style.css" type="text/css" />
</head>

<body>
    <div class="padding-20 container-title">
        <h1>
            MODIFICAR VENDA
        </h1>
    </div>


    <div class="table-client-view">
        <div>
            <form action="php_pdo.php?page=itens_venda&action=editar&codigo=<?= $_GET['codigo'] ?>" method="post" accept-charset="UTF-8">
                <input type="hidden" id="<?= $_GET['codigo'] ?>" />
                <label class="label-control">Cliente</label> <br>
                <select name="codigo_cliente" class="form-control-itens border-produto" style="width: 220px;height:50px;">
                    <?php foreach ($clientes as $index => $cliente) {
                        if ($cliente->nome == $itensEdit->nome) { ?>
                            <option value="<?= $cliente->codigo ?>" selected><?= $cliente->nome ?></option>
                        <?php } else { ?>
                            <option value="<?= $cliente->codigo ?>"><?= $cliente->nome ?></option>
                        <?php } ?>
                    <?php } ?>
                </select><br>

                <select name="codigo_produto" class="form-control-itens border-produto" style="width: 220px;height:50px;">
                    <?php foreach ($produto as $index => $item) {
                        if ($item->nome == $itensEdit->nome) { ?>
                            <option value="<?= $item->codigo ?>" selected><?= $item->produto ?></option>
                        <?php } else { ?>
                            <option value="<?= $item->codigo ?>"><?= $item->produto ?></option>
                        <?php } ?>
                    <?php } ?>
                </select><br>
                <label class="label-control">Quantidade</label>
                <input name="quantidade" type="number" value="<?= $itensEdit->quantidade ?>" class="border-produto form-control-itens">
                <button type="submit" class="style-button" name="enviar">SALVAR</button>
                <a href="ItensVenda.php?page=itens_venda" style="color: black;margin-left: 8px;">VOLTAR</a>
            </form>
        </div>
    </div>

</body>

</html>