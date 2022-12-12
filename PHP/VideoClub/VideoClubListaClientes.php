<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "VideoClub";

$conn = new mysqli($servername, $username, $password, $dbname);

$sql = "select * from Clientes";
$resultado = $conn->query($sql);
?>

<html>

<head></head>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
  integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"
  integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>

<body>
  <div class="container">
    <table class="table table-hover">

      <tr>
        <th>DNI</th>
        <th>NOMBRE</th>
        <th>APELLIDOS</th>
        <th>[borrar]</th>
      </tr>

      <?php while ($fila = $resultado->fetch_assoc()) { ?>
      <tr>
        <td>
          <?= $fila["dni"] ?>
        </td>
        <td>
          <?= $fila["nombre"] ?>
        </td>
        <td>
          <?= $fila["apellido"] ?>
        </td>
        <td>
          <a href="borrarcliente.php?dni=<?= $fila["dni"] ?>" class="btn btn-primary">Borrar</a>
        </td>
        <td>
          <a href="verAlquilerCliente.php?dni=<?= $fila["dni"] ?>" class="btn btn-primary">VerAlquilerClientes</a>
        </td>
    </tr>

    <?php } ?>
    <p>
 
    </p>
  </table>
  <a class="btn btn-primary"  href="formCliente2.html">Nuevo Cliente</a>
  </div>
</body>

</html>
<?php $conn->close(); ?>