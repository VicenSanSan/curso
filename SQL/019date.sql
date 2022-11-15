/*alter table facturas
 add column Fecha Date;
 
 update facturas set fecha="2022-10-10";
 
 
 
 update facturas
 set fecha = "2022-05-05" where
 empresa = "empresaA"
 
 select * from facturas
 
 select day(fecha),
 MONTH(fecha),
 year(fecha)
 from facturas

select date_format(fecha,"%h:%m %e-%M-%Y")
 from facturas;*/

select addDate(fecha,2)from Facturas