
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

------------------------------------- Fill table STOCKSHARES ---------------------------------
insert into stockshare (serialnum, percent, price) values ('ser#-1.1', 25, 25000);
insert into stockshare (serialnum, percent, price) values ('ser#-1.2', 75, 75000);
insert into stockshare (serialnum, percent, price) values ('ser#-2.1', 33, 33000);
insert into stockshare (serialnum, percent, price) values ('ser#-2.2', 67, 25000);

-------------------------------------------- Commit ------------------------------------------------
commit;
