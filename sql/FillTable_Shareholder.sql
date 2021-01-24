------------------------------------- Fill table SHAREHOLDER ---------------------------------

declare 
    typeId number;    
    i_first_name varchar2(100);
    i_last_name varchar2(100);
begin
    for i in 1..4 loop
        i_first_name := create_first_name();
        i_last_name := create_last_name();
        insert into shareholder (firstname, lastname, email, phone, addressid, typeid) 
            values (i_first_name, i_last_name, create_email(i_first_name,i_last_name), create_phone_number(), TRUNC(dbms_random.value(1,100),0), TRUNC(dbms_random.value(1,3),0)); 
   end loop; 
end;
/

-------------------------------------------- Commit ------------------------------------------------
commit;
