# Developer Notes

### Running application in containers
```shell
docker-compose up --build
```

To run in the background
```shell
docker-compose up --build -d
```

### Connecting to the application
The application runs on the port 5006.  To test the CRUD api calls:
https://localhost:5008/swagger/index.html
