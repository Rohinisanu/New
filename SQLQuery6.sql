delete a from book b right join author a on b.authorid=a.aid where b.authorid is null;
update employees
set salary=salary+2162
from employees e inner join departments d on e.department_id=d.department_id
where department_name='IT';
select * from employees;
update employees set salary=salary+2000
where department_id=(select department_id from departments where department_name='IT');


