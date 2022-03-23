<?php
require 'php_pdo.php';

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
            INSERIR PRODUTO
        </h1>
    </div>

    <div class="table-client-view">
        <div>
            <form action="php_pdo.php?page=produto&action=inserir" method="post" accept-charset="UTF-8">
                <input required="required" placeholder="Nome do produto" name="produto" type="text" class="border-produto form-control-itens">
                <input required="required" placeholder="Insira o valor unitário" type="text" name="valor_unitario" step="0.010" type="text" class="border-produto form-control-itens">
                <textarea required="required" placeholder="Descrição do produto" name="descricao" type="text" class="form-control-itens"></textarea>
                <button type="submit" class="style-button" name="enviar" style="margin-left: 5px;">SALVAR</button>
                <a href="Produtos.php?page=produto" style="color: black;margin-left: 8px;">VOLTAR</a>
            </form>
        </div>
    </div>

</body>

</html>