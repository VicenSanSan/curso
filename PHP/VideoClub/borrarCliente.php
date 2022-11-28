<?php
$servidor = "localhost";
$basedatos = "VideoClub";
$usuario = "root";
$password = "";
$sql="delete from clientes where dni ='".$_GET["dni"]."'";
$conn = mysqli_connect($servidor, $usuario, $password, $basedatos);
if (mysqli_query($conn, $sql)) {
      header ('location:VideoClubListaClientes.php');
} else {
      echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}
mysqli_close($conn);
?>
