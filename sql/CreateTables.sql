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
   capacity 		NUMBER(10) not null,
   towerheight     	NUMBER(10)not null,                                                                            
   rotordiameter    NUMBER(10) not null,
   sweptarea   		NUMBER(10) not null   
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table TURBINETYPE is 'Wind turbine types table';                                                        
                                                                                                       
-- Add comments to the columns                                                                             
comment on column TURBINETYPE.id is 'Id';                                                                   
comment on column TURBINETYPE.model is 'Model';  
comment on column TURBINETYPE.capacity is 'Capacity, kW';   
comment on column TURBINETYPE.towerheight is 'Tower height, m';                                                
comment on column TURBINETYPE.rotordiameter is 'Rotor diameter, m'; 
comment on column TURBINETYPE.sweptarea is 'Swept area, sq.m';                                                         
                                                                                                           
-- Create primary, unique key constraints                                                      
create unique index pk_turbinetype on turbinetype (id);                                             
                                                                                                       
alter table turbinetype                                                                                
  add constraint pk_turbinetype primary key (id) using index pk_turbinetype; 
  
------------------------------------- Create table TURBINE ------------------------------------------------

create table TURBINE
(
   id         		NUMBER not null,
   serialnum        VARCHAR2(40 CHAR),
   prodmw       	NUMBER not null,
   turbinetypeid    NUMBER not null
);

-- Add comment to the table 
comment on table TURBINE is 'Wind turbine table';

-- Add comments to the columns 
comment on column TURBINE.id is 'Id';
comment on column TURBINE.serialnum is 'Serial number';
comment on column TURBINE.prodmw is 'Produced energy (MW)';
comment on column TURBINE.turbinetypeid is 'Type id';

-- Create primary, unique and foreign key constraints 
create unique index pk_turbine on turbine (id);

alter table turbine 
  add constraint pk_turbine primary key (id) using index pk_turbine;
  
alter table turbine
  add constraint fk_turbine_turbinetype foreign key (turbinetypeid) references turbinetype (id);

--------------------------------------- Commit ---------------------------------------

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

