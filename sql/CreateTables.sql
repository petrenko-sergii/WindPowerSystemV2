------------------------------- Settings for output ---------------------------------
SET SERVEROUTPUT ON
SET LINESIZE 32767
SET HEADING ON
SET HEADSEP OFF
SET WRAP OFF

------------------------------------- Create table ADDRESSIMAGE ---------------------------------------
create table ADDRESSIMAGE                                                                                 
(                                                                                                          
   id         	NUMBER not null,  
   path         VARCHAR2(500 CHAR) not null
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table ADDRESSIMAGE is 'Address image pathes';                                                        
                                                                                                          
-- Add comments to the columns                                                                             
comment on column ADDRESSIMAGE.id is 'Id';                                                                   
comment on column ADDRESSIMAGE.path is 'Path';                                                                   
                                                                                                           
-- Create primary, unique and foreign key constraints                                                      
create unique index pk_addressimage on addressimage (id);                                             

alter table addressimage                                                                                
  add constraint pk_addressimage primary key (id) using index pk_addressimage; 
  

------------------------------------- Create table FLAGIMAGE ---------------------------------------
create table FLAGIMAGE                                                                                 
(                                                                                                          
   id         	NUMBER not null,  
   path         VARCHAR2(500 CHAR) not null
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table FLAGIMAGE is 'Country flag image pathes';                                                        
                                                                                                          
-- Add comments to the columns                                                                             
comment on column FLAGIMAGE.id is 'Id';                                                                   
comment on column FLAGIMAGE.path is 'Path';                                                                   
                                                                                                           
-- Create primary, unique and foreign key constraints                                                      
create unique index pk_flagimage on flagimage (id);                                             

alter table flagimage                                                                                
  add constraint pk_flagimage primary key (id) using index pk_flagimage;   
 
 
------------------------------------- Create table APPIMAGE ---------------------------------------
create table APPIMAGE                                                                                 
(                                                                                                          
   id         	NUMBER not null,  
   path         VARCHAR2(500 CHAR) not null
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table APPIMAGE is 'APP image pathes';                                                        
                                                                                                          
-- Add comments to the columns                                                                             
comment on column APPIMAGE.id is 'Id';                                                                   
comment on column APPIMAGE.path is 'Path';                                                                   
                                                                                                           
-- Create primary, unique and foreign key constraints                                                      
create unique index pk_appimage on appimage (id);                                             

alter table appimage                                                                                
  add constraint pk_appimage primary key (id) using index pk_appimage; 

  
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
    add constraint uk_turbine_serialnum unique (serialnum); 

alter table turbine 
  add constraint pk_turbine primary key (id) using index pk_turbine;
  
alter table turbine
  add constraint fk_turbine_turbinetype foreign key (turbinetypeid) references turbinetype (id);
  
------------------------------------- Create table SHAREHOLDERTYPE ---------------------------------------
create table SHAREHOLDERTYPE                                                                                  
(                                                                                                          
   id         	NUMBER not null,  
   name         VARCHAR2(200 CHAR) not null
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table SHAREHOLDERTYPE is 'Share holder type: private or legal pesron';                                                    
                                                                                                     
-- Add comments to the columns                                                                             
comment on column SHAREHOLDERTYPE.id is 'Id';                                                                
comment on column SHAREHOLDERTYPE.name is 'Name';                                                                   
                                                                                                            
-- Create primary, unique key constraints                                                       
create unique index pk_shareholdertype on shareholdertype (id);                                             
                                                                                                     
alter table shareholdertype                                                                                
  add constraint pk_shareholdertype primary key (id) using index pk_shareholdertype; 
  
------------------------------------- Create table SHAREHOLDER ---------------------------------------

create table SHAREHOLDER                                                                                  
(                                                                                                          
   id         	NUMBER not null,  
   firstname    VARCHAR2(200 CHAR) not null,
   lastname     VARCHAR2(200 CHAR),
   email  		VARCHAR2(200 CHAR) not null,
   phone  		VARCHAR2(200 CHAR) not null,
   typeid   	NUMBER not null
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table SHAREHOLDER is 'Share holder table';                                                        
                                                                                                          
-- Add comments to the columns                                                                             
comment on column SHAREHOLDER.id is 'Id';                                                                  
comment on column SHAREHOLDER.firstname is 'First name';                                                                   
comment on column SHAREHOLDER.lastname is 'Last name';                                                                   
comment on column SHAREHOLDER.email is 'Email';                                                                   
comment on column SHAREHOLDER.phone is 'Phone number';                                                                   
comment on column SHAREHOLDER.typeid is 'Type id';                                                                   
                                                                                                           
-- Create primary, unique and foreign key constraints                                                      
create unique index pk_shareholder on shareholder (id);                                             
                                                                                                       
alter table shareholder                                                                                
  add constraint pk_shareholder primary key (id) using index pk_shareholder;                            

alter table shareholder
  add constraint fk_shareholder_type foreign key (typeid) references shareholdertype (id);
  
------------------------------------- Create table STOCKSHARE ---------------------------------------

create table STOCKSHARE                                                                                  
(                                                                                                          
   id         		NUMBER not null, 
   serialnum        VARCHAR2(40 CHAR) not null,
   percent      	NUMBER(10) not null,
   price        	NUMBER not null,
   turbineid   		NUMBER
);                                                                                                          
                                                                                                           
-- Add comment to the table                                                                                
comment on table STOCKSHARE is 'Share table (stores data about turbine/farm shareholders)';                                                        
                                                                                                          
-- Add comments to the columns                                                                             
comment on column STOCKSHARE.id is 'Id'; 
comment on column STOCKSHARE.serialnum is 'Serial number';                                                                   
comment on column STOCKSHARE.percent is 'Share percent(%)';                                                                   
comment on column STOCKSHARE.price is 'Price (euro)';      
comment on column STOCKSHARE.turbineid is 'Turbine id';                                                              
                                                                                                           
-- Create primary, unique and foreign key constraints                                                      
create unique index pk_stockshare on stockshare (id);  

alter table stockshare
    add constraint uk_stockshare_serialnum unique (serialnum);                                           
                                                                                                       
alter table stockshare                                                                                
  add constraint pk_stockshare primary key (id) using index pk_stockshare;   

alter table stockshare
  add constraint fk_stockshare_turbine foreign key (turbineid) references turbine (id);  

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

