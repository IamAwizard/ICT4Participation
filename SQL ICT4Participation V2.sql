	--ICT4Participation SQL Script

	--DROP
	drop table TQUESTION 	cascade constraints;
	drop table TUSER 		cascade constraints;
	drop table TAFSPRAAK 	cascade constraints;
	drop table TREVIEW 		cascade constraints;
	drop table TGESPREK 	cascade constraints;
	drop table TADMIN 		cascade constraints;
	drop table TVOLUNTEER 	cascade constraints;
	drop table TCLIENT		cascade constraints;
	drop table TCHATBERICHT cascade constraints;
	drop table TDAG			cascade constraints;
	drop table TROOSTER		cascade constraints;
	
	--drop sequence
	drop sequence seq_QUESTION;
	drop sequence seq_USER;
	drop sequence seq_AFSPRAAK;
	drop sequence seq_REVIEW;
	drop sequence seq_GESPREK;
	drop sequence seq_ADMIN;
	drop sequence seq_VOLUNTEER;
	drop sequence seq_CLIENT;
	drop sequence seq_CHATBERICHT;
	drop sequence seq_DAG;
	drop sequence seq_ROOSTER;
	
	
	--CREATE
		create table TUSER (
	UserID					number(8)		primary key,
	Naam					varchar2(255)	not null,
	Geboortedatum			DATE			not null,
	Geslacht				varchar2(255)	not null,
	Woonplaats				varchar2(255)	not null,
	Adres					varchar2(255)	not null,
	Email					varchar2(255)	,
	Wachtwoord				varchar2(255)	not null,
	Type					varchar2(255)	not null,
	
	constraint chk_TUSER_GESLACHT check(UPPER(Geslacht) in('M', 'V'))
	);
	
	create table TQUESTION (
	QuestionID				number(8)		primary key,
	Auteur					number(8)		not null,
	Vraag					varchar2(255)	not null,
	Bijzonderheid			varchar2(255)	,
	Locatie					varchar2(255)	,
	Afstand					varchar2(255)	,
	Vervoer					varchar2(255)	,
	Datum					DATE			not null,
	Opgelost				varchar2(3)		not null,
	Antwoord				varchar2(1024)	,
	
	
	constraint fk_TUSER_QuestionID foreign key(Auteur)REFERENCES TUSER(USERID) on delete cascade,
	constraint chk_TQUESTION_OPGELOST check(UPPER(Opgelost) in('JA', 'NEE'))
	);
	
	create table TAFSPRAAK (
	AfspraakID				number(8)		primary key,
	Client					number(8)		not null,
	Volunteer				number(8)		not null,
	Datumtijd				varchar2(255)	not null,
	Locatie 				varchar2(255)	not null,
	
	constraint fk_TAFSPRAAK_Client	foreign key(Client)REFERENCES TUSER(UserID) on delete cascade,
	constraint fk_TAFSPRAAK_Volunteer foreign key(Volunteer)REFERENCES TUSER(UserID) on delete cascade
	);
	
	create table TREVIEW (
	ReviewID				number(8)		primary key,
	Datum					varchar2(255)	not null,
	Volunteer				number(8)		not null,
	Client					number(8)		not null,
	Rating 					number(1)		not null,
	Tekst					varchar2(1024)	,
	
	constraint fk_TREVIEW_Client	foreign key(Client)REFERENCES TUSER(UserID) on delete cascade,
	constraint fk_TREVIEW_Volunteer foreign key(Volunteer)REFERENCES TUSER(UserID) on delete cascade,
	constraint chk_TREVIEW_RATING check(Rating in (1, 2, 3, 4, 5))
	);
	
	create table TGESPREK (
	GesprekID				number(8)		primary key,
	UserID1					number(8)		not null,
	UserID2					number(8)		not null,
	
	constraint fk_TGESPREK_UserID1 foreign key(UserID1)REFERENCES TUSER(UserID) on delete cascade,
	constraint fk_TGESPREK_UserID2 foreign key(UserID2)REFERENCES TUSER(UserID) on delete cascade
	);
	
	create table TADMIN (
	AdminID					number(8)		primary key,
	UserID					number(8) not null,
	
	contraint fk_TADMIN_UserID foreign key(UserID) REFERENCES TUSER(UserID) on delete cascade 
	);
	
	create table TVOLUNTEER (
	VolunteerID				number(8)		primary key,
	Rijbewijs				varchar2(3)		not null,
	Biografie 				varchar2(255)	,
	VOG						varchar2(255)	not null,
	Foto					varchar2(255)	not null,
	
	constraint chk_TVOLUNTEER_RIJBEWIJS check(UPPER(Rijbewijs) in ('JA', 'NEE'))
	);
	
	create table TCLIENT (
	ClientID				number(8)		primary key,
	UserID					number(8) not null,
	
	contraint fk_TCLIENT_UserID foreign key(UserID) REFERENCES TUSER(UserID) on delete cascade
	);
	
	create table TCHATBERICHT (
	BerichtID				number(8)		primary key,
	GesprekID				number(8)		not null,
	Afzender				number(8)		not null,
	Bericht					varchar2(255)	not null,
	Datum					varchar2(255)	not null,

	constraint fk_TCHATBERICHT_Gesprek foreign key(GesprekID)REFERENCES TGESPREK(GesprekID) on delete cascade,
	constraint fk_TCHATBERICHT_Afzender foreign key(Afzender)REFERENCES TUSER(UserID) on delete cascade
	);
	
	create table TDAG (
	DagID					number(8)		primary key,
	Dag						varchar2(255)	not null,
	Begintijd				varchar2(255)	not null,
	Eindtijd				varchar2(255)	not null,
	
	constraint chk_TDAG_DAG check(UPPER(Dag) in ('MAANDAG', 'DINSDAG', 'WOENSDAG', 'DONDERDAG', 'VRIJDAG', 'ZATERDAG', 'ZONDAG'))
	);
	
	create table TROOSTER (
	RoosterID				number(8)		primary key,
	VolunteerID				number(8)		not null,
	DagID					number(8)		not null,
	
	constraint fk_TROOSTER_VolunteerID	foreign key(VolunteerID)REFERENCES TVOLUNTEER(VolunteerID) on delete cascade,
	constraint fk_TROOSTER_DagID		foreign key(DagID)REFERENCES TDAG(DagID) on delete cascade
	);
	
	--QUESTION
	CREATE Sequence seq_QUESTION
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_QUESTION
	before insert on TQUESTION
	for each row
	begin
	select seq_QUESTION.nextval into :new.QuestionID from dual;
	end;
	/
	
	--ANTWOORD
	CREATE Sequence seq_ANTWOORD
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_ANTWOORD
	before insert on TANTWOORD
	for each row
	begin
	select seq_ANTWOORD.nextval into :new.AntwoordID from dual;
	end;
	/
	
	--TUSER
	CREATE Sequence seq_USER
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_USER
	before insert on TUSER
	for each row
	begin
	select seq_USER.nextval into :new.USERID from dual;
	end;
	/
	
	--TAFSPRAAK
	CREATE Sequence seq_AFSPRAAK
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_AFSPRAAK
	before insert on TAFSPRAAK
	for each row
	begin
	select seq_AFSPRAAK.nextval into :new.AfspraakID from dual;
	end;
	/
	
	--TREVIEW
	CREATE Sequence seq_REVIEW
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_REVIEW
	before insert on TREVIEW
	for each row
	begin
	select seq_REVIEW.nextval into :new.ReviewID from dual;
	end;
	/
	
	--TGESPREK
	CREATE Sequence seq_GESPREK
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_GESPREK
	before insert on TGESPREK
	for each row
	begin
	select seq_Gesprek.nextval into :new.GesprekID from dual;
	end;
	/
	
	--TADMIN
	CREATE Sequence seq_ADMIN
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_ADMIN
	before insert on TADMIN
	for each row
	begin
	select seq_ADMIN.nextval into :new.AdminID from dual;
	end;
	/
	
	--TVOLUNTEER
	CREATE Sequence seq_VOLUNTEER
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_VOLUNTEER
	before insert on TVOLUNTEER
	for each row
	begin
	select seq_VOLUNTEER.nextval into :new.VolunteerID from dual;
	end;
	/
	
	--TCLIENT
	CREATE Sequence seq_CLIENT
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_CLIENT
	before insert on TCLIENT
	for each row
	begin
	select seq_CLIENT.nextval into :new.ClientID from dual;
	end;
	/
	
	--TCHATBERICHT
	CREATE Sequence seq_CHATBERICHT
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_CHATBERICHT
	before insert on TCHATBERICHT
	for each row
	begin
	select seq_CHATBERICHT.nextval into :new.BerichtID from dual;
	end;
	/
	
	--TDAG
	CREATE Sequence seq_DAG
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_DAG
	before insert on TDAG
	for each row
	begin
	select seq_DAG.nextval into :new.DagID from dual;
	end;
	/
	
	--TROOSTER
	CREATE Sequence seq_ROOSTER
	minvalue 1
	start with 1
	increment by 1
	cache 10;

	CREATE Trigger trigger_ROOSTER
	before insert on TROOSTER
	for each row
	begin
	select seq_ROOSTER.nextval into :new.RoosterID from dual;
	end;
	/

	commit;