#!/bin/sh
sudo -u postgres psql <<EOF
\c postgres
DROP DATABASE csharpproject;
CREATE USER appuser WITH PASSWORD 'banaan';
CREATE DATABASE csharpproject;
GRANT ALL PRIVILEGES ON DATABASE csharpproject TO appuser;
EOF

echo '--> next run makefile in project folder to add the db files:'
echo '`$ make migration mname=Initial`'

echo '--> then run makefile again to add the database:'
echo '`$ make db`'
