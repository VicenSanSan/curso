<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <table border="1px solid black">
        <tr>
            <th>Tabla de  multiplicar </th>
        </tr>

        <?php for ($i=0;$i<10;$i++) {?>
            <tr>
                <td align="center"><?=($i*$_GET["numero"])?></td>
            </tr>
            <?php }?>
    </table>
</body>
</html>