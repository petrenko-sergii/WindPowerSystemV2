------------------------------------- Fill table ADDRESSIMAGE ---------------------------------------
declare
    root_folder VARCHAR2(200) := 'Content\Images\Address\Town\'; 
	town_name VARCHAR2(100) := 'Kolding\';
	
begin
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_10.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_12.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_22.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_24.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_37.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_76.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_79.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_89.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_100.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_102.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_104.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_117.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_120.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Haderslevvej_124.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_1.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_2.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_3.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_4.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_5.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_6.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_7.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_13.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_15.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_17.jpg');
	insert into addressimage (path) values (root_folder || town_name || 'Kolding_Ndr_Ringvej_49.jpg');
	
    town_name := 'Odense\';
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_50.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_53.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_65.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_67.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_109.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_111.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_115.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_119.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_155.jpg');
    insert into addressimage (path) values (root_folder || town_name || 'Odense_Middelfartvej_165.jpg');
   
     commit;
    
 exception
      when VALUE_ERROR
        then dbms_output.put_line('Value error. Make sure your input is correct.');
      when others
        then dbms_output.put_line('Unknown error occured. Could not insert data in the table: ADDRESSIMAGE');
        rollback;
end;
/

------------------------------------- Fill table APPIMAGE ---------------------------------------
declare
    root_folder VARCHAR2(200) := 'Content\Images\TurbineTypes\'; 
	manufacturer_name VARCHAR2(100) := 'Vestas\';
	
begin
	insert into appimage (path) values (root_folder || manufacturer_name || 'V39_600.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'V47_660.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'V52_850.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'V80_2000.jpg');
	
	manufacturer_name := 'Siemens\';
	insert into appimage (path) values (root_folder || manufacturer_name || 'SG_21_114.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'SG_26_126.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'SWT_DD-120.jpg');
	
	manufacturer_name := 'Nordex\';
	
	insert into appimage (path) values (root_folder || manufacturer_name || 'N43.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'N50.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'N52.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'N80.jpg');
	
	manufacturer_name := 'Enercon\';
	insert into appimage (path) values (root_folder || manufacturer_name || 'E-32.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'E-44.jpg');
	insert into appimage (path) values (root_folder || manufacturer_name || 'E-66.jpg');
   
     commit;
    
 exception
      when others
        then dbms_output.put_line('Unknown error occured. Could not insert data in the table: APPIMAGE');
        rollback;
end;
/

------------------------------------- Fill table FLAGIMAGE ---------------------------------------

declare
    root_folder VARCHAR2(200) := 'Content\Images\CountryFlags\'; 
	
begin
    insert into flagimage (path) values (root_folder || 'AustriaFlag.jpg');
    insert into flagimage (path) values (root_folder || 'BelgiumFlag.jpg');
    insert into flagimage (path) values (root_folder || 'DenmarkFlag.jpg');
    insert into flagimage (path) values (root_folder || 'FinlandFlag.jpg');
    insert into flagimage (path) values (root_folder || 'GermanyFlag.jpg');
    insert into flagimage (path) values (root_folder || 'FranceFlag.jpg');
    insert into flagimage (path) values (root_folder || 'NetherlandsFlag.jpg');
    insert into flagimage (path) values (root_folder || 'NorwayFlag.jpg');
    insert into flagimage (path) values (root_folder || 'PolandFlag.jpg');
    insert into flagimage (path) values (root_folder || 'SwedenFlag.jpg');
    insert into flagimage (path) values (root_folder || 'UnitedKingdomFlag.jpg');
      
    commit;
    
 exception
     when others
       then dbms_output.put_line('Unknown error occured. Could not insert data in the table: FLAGIMAGE');
       rollback;
end;
/

------------------------------------- Fill table TURBINETYPE ---------------------------------

---- Vestas
insert into turbinetype (model, capacity, towerheight, rotordiameter, sweptarea) values ('test1', 100, 101, 102, 103);
insert into turbinetype (model, capacity, towerheight, rotordiameter, sweptarea) values ('test2', 200, 201, 202, 203);
insert into turbinetype (model, capacity, towerheight, rotordiameter, sweptarea) values ('test3', 300, 301, 302, 303);
insert into turbinetype (model, capacity, towerheight, rotordiameter, sweptarea) values ('test4', 400, 401, 402, 403);

------------------------------------- Fill table TURBINE ---------------------------------
insert into turbine (serialnum, prodmw, turbinetypeid) values ('ser#-1', 100, 1);
insert into turbine (serialnum, prodmw, turbinetypeid) values ('ser#-2', 200, 2);
insert into turbine (serialnum, prodmw, turbinetypeid) values ('ser#-3', 300, 2);
insert into turbine (serialnum, prodmw, turbinetypeid) values ('ser#-4', 400, 4);

------------------------------------- Fill table SHAREHOLDERTYPE ---------------------------------
insert into shareholdertype (name) values ('Legal person');
insert into shareholdertype (name) values ('Private person');

------------------------------------- Fill table STOCKSHARES ---------------------------------
insert into stockshare (serialnum, percent, price, turbineid) values ('ser#-1.1', 25, 25000,1);
insert into stockshare (serialnum, percent, price, turbineid) values ('ser#-1.2', 75, 75000,1);
insert into stockshare (serialnum, percent, price, turbineid) values ('ser#-2.1', 33, 33000,2);
insert into stockshare (serialnum, percent, price, turbineid) values ('ser#-2.2', 67, 25000,2);

-------------------------------------------- Commit ------------------------------------------------
commit;
