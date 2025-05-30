
delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end 
//


/*------------------- PROCEDIMIENTO PARA LA CREACION DE UN NUEVO SOCIO ---------------------------*/


 drop procedure if exists NuevoSoc;	
 create procedure NuevoSoc(in Nom varchar(30),in Ape varchar(20),in Tip varchar(20), in Doc int, in Dir varchar(20), in Inscrip date, in Carnet boolean, out rta int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socio);
     if filas = 0 then
		set filas = 452; 
     else
		set filas = (select max(NumCarnet) + 1 from socio);
		set existe = (select count(*) from socio where TipoDoc = Tip and Documento = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into socio values(filas,Nom,Ape,Tip,Doc,Dir,Inscrip,Carnet);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
end //

/* PROCEDIMIENTO PARA LISTAR A TODOS LOS SOCIOS */


/* PROCEDIMIENTO PARA LISTAR AQUELLOS SOCIOS QUE SE LES VENCE LA CUOTA EL DIA DE LA FECHA */


/* PROCEDIMIENTO PARA LISTAR AQUELLOS SOCIOS MOROSOS */


/* PROCEDIMIENTO PARA PAGAR CUOTA */


/* PROCEDIMIENTO PARA NO SOCIOS */

DROP PROCEDURE IF EXISTS NuevoNoSoc;	
CREATE PROCEDURE NuevoNoSoc(IN Nom VARCHAR(30), IN Ape VARCHAR(20), IN Tip VARCHAR(20), IN Doc INT, IN Dir VARCHAR(20), OUT rta INT)
BEGIN
    DECLARE filas INT DEFAULT 0;
    DECLARE existe INT DEFAULT 0;

    SELECT COUNT(*) INTO filas FROM noSocio;

    IF filas = 0 THEN
        SET filas = 452; -- Número inicial
    ELSE
        SELECT MAX(IdNoSocio) + 1 INTO filas FROM noSocio;
        SELECT COUNT(*) INTO existe FROM noSocio WHERE TipoDoc = Tip AND Documento = Doc;
    END IF;

    IF existe = 0 THEN
        INSERT INTO noSocio VALUES(filas, Nom, Ape, Tip, Doc, Dir);
        SET rta = filas;
    ELSE
        SET rta = existe;
    END IF;
END //

/* PROCEDIMIENTO PARA PAGAR LA CUOTA DIARIA DE LA ACTIVIDAD */
