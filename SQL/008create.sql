/*create table personita(nombre varchar(20), edad int);
 
 
 create table regalo
 (descripcion varchar(20), importe int, personita_nombre varchar(20))
 
 show tables;
 
 insert into personita VALUES ("Ana", 7);
 insert into personita VALUES ("Noe", 5);
 insert into personita VALUES ("Jose", 6);
 
 
 insert into regalo values ("lego",30,"David");
 insert into regalo values ("Barbie",50,"Noe");
 insert into regalo values ("consola", 300, "Ana");
 
 
 DELETE FROM 
 regalo WHERE personita_nombre = "Jose"
 
 insert into regalo values ("patinete", 100, "Jose");


select nombre as nombreNiño
from personita,
    regalo
where nombre = personita_nombre;

select nombre as nombreNiño, descripcion as nombreRegalo, edad, importe 
from personita
    inner join regalo on personita.nombre = regalo.personita_nombre;

  insert into personita values ("Toni", 6); 

  select nombre as nombreNiño, descripcion as nombreRegalo, edad, importe 
from personita
    left join regalo on personita.nombre = regalo.personita_nombre;

    insert into regalo value ("caja de música", 30, null)*/

     select nombre as nombreNiño, descripcion as nombreRegalo, edad, importe 
from personita
    right join regalo on personita.nombre = regalo.personita_nombre;

