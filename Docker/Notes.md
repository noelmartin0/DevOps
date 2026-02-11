# 🐳 Basic Docker Commands – Quick Reference Guide

This document contains essential Docker commands every beginner should know.

---

## 📦 1. Build an Image

```bash
docker build -t <image_name> .
```

* `-t` → Tag (name) the image
* `.` → Build from current directory (Dockerfile location)

---

## 🚀 2. Run a Container

```bash
docker run -d --name <container_name> <image_name>
```

* `-d` → Run in detached mode (background)
* `--name` → Assign container name

---

## 🖥 3. Run Container with Port Mapping

```bash
docker run -d -p 8080:80 --name <container_name> <image_name>
```

* `8080` → Host port
* `80` → Container port

---

## 🔎 4. View Running Containers

```bash
docker ps
```

---

## 📋 5. View All Containers (Including Stopped)

```bash
docker ps -a
```

---

## 📜 6. View Container Logs

```bash
docker logs <container_name>
```

Follow logs live:

```bash
docker logs -f <container_name>
```

---

## 🛑 7. Stop a Container

```bash
docker stop <container_name>
```

---

## ❌ 8. Remove a Container

```bash
docker rm <container_name>
```

Force remove:

```bash
docker rm -f <container_name>
```

---

## 🗑 9. Remove an Image

```bash
docker rmi <image_name>
```

---

## 🖱 10. Run in Interactive Mode

```bash
docker run -it <image_name> /bin/bash
```

If bash is not available:

```bash
docker run -it <image_name> /bin/sh
```

* `-i` → Interactive
* `-t` → Allocate terminal

---

## 🔗 11. Docker Networks

Create network:

```bash
docker network create <network_name>
```

Run container in network:

```bash
docker run -d --network <network_name> <image_name>
```

List networks:

```bash
docker network ls
```

Inspect network:

```bash
docker network inspect <network_name>
```

---

## 📂 12. Volume Mount (Bind Mount)

```bash
docker run -d -v $(pwd):/app <image_name>
```

* Mount current directory into container `/app`

---

## 🧹 13. Clean Up

Remove unused containers, networks, images:

```bash
docker system prune
```

Remove everything (use carefully):

```bash
docker system prune -a
```

---

# ✅ Summary

These commands cover:

* Building images
* Running containers
* Debugging
* Networking
* Volumes
* Cleanup

This is your essential Docker starter toolkit 🚀
