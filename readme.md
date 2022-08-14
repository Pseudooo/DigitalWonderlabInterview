
## Database
To create the application account and schema use the following:
```sql
CREATE ROLE wonderlab LOGIN PASSWORD 'averystrongpassword';
CREATE SCHEMA wonderlab AUTHORIZATION wonderlab;
GRANT USAGE ON SCHEMA wonderlab TO PUBLIC;
ALTER USER wonderlab CREATEDB;
```