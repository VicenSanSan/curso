/*select sum(importe) as gasto,empresa
 from facturas
 GROUP BY empresahabing gasto>3000
 
 select avg(importe) as media,empresa FROM facturas
 GROUP BY empresa having media>100*/


select max(importe) as importeMax,
     concepto
from facturas
group BY empresa
HAVING importeMax > 100