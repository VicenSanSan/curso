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
    
  </table>
    
<?php $conn->close(); ?>