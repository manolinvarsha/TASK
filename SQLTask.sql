--Print the city name and the count of authors from every city
select city , count(au_id)author_count from authors group by city


--Print the authors who are not from the city in which the publisher 'New Moon Books' is from.
select au_fname,au_lname,city from authors
where city in (select city from publishers where pub_name!='New Moon Books')


--Create a procudure that will take the author first name and last name and new price  The procedure should update teh price of the books written by the author with the give name 
create proc proc_PriceUpdate(@fname varchar(20),
@lname varchar(20),@price varchar(20))
as
begin
update titles set price=@price where title_id in
(select title_id from titleauthor where au_id in      
(select au_id from authors where au_fname=@fname and au_lname=@lname))
end
exec proc_PriceUpdate 'Ann','Dull','1000'

select*from titles 


--Create a function that will calculate tax for the sale of every book If quantity <10 tax is 2% 10 -20 tax is 5% 20 - 50 tax is 6% above 30 tax is 7.5% The fuction should take quantity and return tax
create function fn_CalculateTaxSales(@quantity int)
returns float
as
begin
declare
@tax int
if(@quantity < 10)
set @tax=2
else if(@quantity>10 and @quantity<=20)
set @tax=5
else if(@quantity>20 and @quantity<=50)
set @tax=6
else
set @tax=7.5
return @tax
end

select qty,dbo. fn_CalculateTaxSales(qty) 'Tax' from sales