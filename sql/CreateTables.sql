------------------------------- Settings for output ---------------------------------
SET SERVEROUTPUT ON
SET LINESIZE 32767
SET HEADING ON
SET HEADSEP OFF
SET WRAP OFF


  
------------------------------------- Create table TURBINETYPE --------------------------------------------
create table TURBINETYPE                                                                                   
(                                                                                                          
   id         		NUMBER not null,                                                                       
   model 			VARCHAR2(200 CHAR) not null, 
   capacity 		NUMBER(10) not null                                                                            
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table TURBINETYPE is 'Wind turbine types table';                                                        
                                                                                                       
-- Add comments to the columns                                                                             
comment on column TURBINETYPE.id is 'Id';                                                                   
comment on column TURBINETYPE.model is 'Model';  
comment on column TURBINETYPE.capacity is 'Capacity, kW';                                                           
                                                                                                           
-- Create primary, unique key constraints                                                      
create unique index pk_turbinetype on turbinetype (id);                                             
                                                                                                       
alter table turbinetype                                                                                
  add constraint pk_turbinetype primary key (id) using index pk_turbinetype; 

commit;

------------------------------- Print the log-message ---------------------------------

BEGIN
	DBMS_OUTPUT.PUT_LINE('****************************************************************');
	DBMS_OUTPUT.PUT_LINE('*********------------------------------------------*************');
	DBMS_OUTPUT.PUT_LINE('*********---- TABLES ARE CREATED SUCCESSFULLY -----*************');
	DBMS_OUTPUT.PUT_LINE('*********------------------------------------------*************');
	DBMS_OUTPUT.PUT_LINE('****************************************************************');
END;
/

