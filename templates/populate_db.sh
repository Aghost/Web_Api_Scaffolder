#!/bin/sh
sudo -u postgres psql <<EOF
\c csharpproject
insert into "Movies" ("Name", "Data", "CreatedOn", "UpdatedOn")
values ('henkiemovie', 'henkiedata henkiedata henkiedata ', '10-10-2010', '10-20-2020'),
('jaapiemovie', 'jaapiedata jaapiedata jaapiedata ', '1-2-2003', '4-5-2006');

insert into "ITEM" ("Name", "Data", "CreatedOn", "UpdatedOn")
values ('customitemname1', 'i am le custom item', '1-2-2013', '5-6-2017'),
('customitemname2', 'i am le custom item 2', '10-10-2010', '10-20-2020');

select * from "Movies";
select * from "ITEM";
EOF
