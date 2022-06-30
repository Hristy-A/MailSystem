# MailSystem

This repository presents file, preparing for creating mail system.

## Setup guide:
1. Pull repository in local folder (check for only latin symbols in path)
2. If you using docker desktop - disable "_Use docker compose V2_" option
3. Set password for database with command `echo <password> | docker secret create mysql_db_root -`. Use `docker secret <param>` command for configuring secrets.
4. Choose Docker Compose as sturtup option.

All ready.
