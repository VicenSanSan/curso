<html>
    <body>
    <p> el número mayor es </p>
<?php 
$numero1=$_GET["numero1"];
$numero2=$_GET["numero2"];


if ($numero1>=$numero2){
    echo $numero1;} else{
        echo $numero2;
    }


?>

</body>
</html>