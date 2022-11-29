select * from Doctor cross join AdmittedPatient;
select * from Doctor d inner join AdmittedPatient ap on d.did=ap.did;
select * from Doctor d left join AdmittedPatient ap on d.did=ap.did;
select count(*) from Doctor d inner join AdmittedPatient ap on d.did=ap.did;
update employees 
set salary=salary+2160 from employees e inner join departments d on e.department_id=d.department_id;
update employees set salary=salary+3000 from employees e inner join departments d on e.department_id=d.department_id where department_name='IT';
update employees set salary =salary+1000 from employees e inner join departments d on e.department_id=d.department_id where department_name='Finance';
update employees set salary =salary+1000 from employees e inner join departments d on e.department_id=d.department_id where department_name='HR';
update employees set salary =salary+1000 from employees e inner join departments d on e.department_id=d.department_id where department_name='Maintenance';
delete a from book b left join author a on b.authorid=a.aid where b.authorid=null;
delete a from book b right join author a on b.authorid=a.aid where b.authorid=null;
delete a from book b right join author a on b.authorid=a.aid;