<?php
$servidor = "localhost";
$basedatos = "VideoClub";
$usuario = "root";
$password = "";

$sql="insert into Clientes(dni,nombre,apellido) values(".$_GET["dni"].",'".$_GET["nombre"]."','".$_GET["apellido"]."');";
$conn = mysqli_connect($servidor, $usuario, $password, $basedatos);
if (mysqli_query($conn, $sql)) {
      header ('location:VideoClubListaClientes.php');
} else {
      echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}
mysqli_close($conn);
?>


</body>

</html>