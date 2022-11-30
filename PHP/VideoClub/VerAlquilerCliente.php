<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "VideoClub";

$conn = new mysqli($servername, $username, $password, $dbname);

/*$sql="select * from alquiler where clientes_dni='" .$_GET["dni"]."'";
select
    numero,
    date_format(fecha, '%d/%m/%Y') as fecha,
    titulo
from
    Alquileres
    inner join Peliculas on Alquileres.peliculas_isbn = Peliculas.isbn
where
    clientes_dni = '1'*/


$sql= "select numero, date_format(fecha,'%d/%m/%Y') as fecha, titulo from alquiler inner join peliculas
on alquiler.peliculas_isbn= peliculas.isbn where  clientes_dni='" .$_GET["dni"]."'";

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
        <th>NUMERO</th>
        <th>FECHA</th>
        <th>titulo</th>
      </tr>

      <?php while ($fila = $resultado->fetch_assoc()) { ?>
      <tr>
        <td>
          <?= $fila["numero"] ?>
        </td>
        <td>
          <?= $fila["fecha"] ?>
        </td>
        <td>
          <?= $fila["titulo"] ?>
        </td>
        
        
    </tr>

    <?php } ?>
    <p>
 
    </p>
  </table>
  
  </div>
</body>

</html>
<?php $conn->close(); ?>