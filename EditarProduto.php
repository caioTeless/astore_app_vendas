<?php

$action = 'recuperar';
require 'php_pdo.php';

$itemEdit = array();
foreach ($itens as $index => $item) {
    if ($item->codigo == $_GET['codigo']) {
        $itemEdit = $item;
    }
}

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
            MODIFICAR PRODUTO
        </h1>
    </div>

    <div class="table-client-view">
        <div>
            <form action="php_pdo.php?page=produto&action=editar&codigo=<?= $itemEdit->codigo ?>" method="post" accept-charset="UTF-8">
                <input type="hidden" id="<?= $itemEdit->codigo ?>">
                <input required="required" placeholder="Nome do produto" name="produto" type="text" value="<?= $itemEdit->produto ?>" class="border-produto form-control-itens">
                <input required="required" placeholder="Insira o valor unitário" name="valor_unitario" value="<?= $itemEdit->valor_unitario ?>" step="0.010" title="Inserir ponto" type="text" class="border-produto form-control-itens">
                <textarea required="required" placeholder="Descrição do produto" name="descricao" type="text" class="form-control-itens"><?= $itemEdit->descricao ?></textarea>
                <button type="submit" class="style-button" name="enviar" style="margin-left: 5px;">SALVAR</button>
                <a href="Produtos.php?page=produto" style="color: black;margin-left: 8px;">VOLTAR</a>
            </form>
        </div>
    </div>

</body>

</html>