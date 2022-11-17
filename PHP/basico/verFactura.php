<?php
$servidor = "localhost";
$basedatos = "curso2";
$usuario = "root";
$password = "";

?>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <p>LA FACTURA ES </p>
    <p>Número de factura: <?= $_GET["numero"] ?>
    </p>
    <p> Concepto: <?= $_GET["concepto"] ?>
    </p>
    <p> Importe: <?= $_GET["importe"] ?>
    </p>
<?php
   // $sql="insert into facturas values(88,'pantalla',299,'empresaB','2022-12-12');"
    $sql="insert into facturas(numero,concepto,importe) values(".$_GET["numero"].",'".$_GET["concepto"]."',".$_GET["importe"].");";
    echo $sql
   
?>
<?php

// Crea la conexion
$conn = mysqli_connect($servidor, $usuario, $password, $basedatos);
// Check connection
if (!$conn) {
    echo ("La conexion ha fallado" . mysqli_connect_error());
}
if (mysqli_query($conn, $sql)) {
      echo "Fila añadida correctamente";
} else {
      echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}
mysqli_close($conn);
?>


</body>

</html>