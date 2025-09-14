# MEGUTube Backend

An open-source social media, where registered users can upload their awesome videos, without censure and limitations.

## Installation

Install and run daemon your own instance in docker

```bash
  docker build -t megu_tube .
  docker run -d --restart=always -v C:/megu/photos:/app/photos -v C:/megu/videos:/app/videos --name megu_tube_container -p 5463:80 megu_tube
  docker run -d --restart=always -v /megu/photos:/app/photos -v /megu/videos:/app/videos --name megu_tube_container -p 5463:80 megu_tube

  docker ps -a
  docker stop megu_tube_container
  docker rm megu_tube_container

  docker rmi megu_tube
```
    
