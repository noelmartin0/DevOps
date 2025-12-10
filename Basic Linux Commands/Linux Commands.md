# Linux for DevOps – Quick Reference Guide

---

## 🧩 Basic Commands
| Command | Description |
|--------|-------------|
| `man <command>` | Show manual/help for any command |
| `clear` | Clear terminal screen |
| `pwd` | Show present working directory |
| `echo "value"` | Print a string or variable |
| `whoami` | Show current logged-in user |
| `su <username>` | Switch user |
| `env` | List environment variables |
| `history` | Show command history |
| `date` | Display system date & time |

---

## 👤 User Management
| Command | Description | Flags |
|--------|-------------|--------|
| `sudo bash` | Switch to root shell | — |
| `sudo useradd <user>` | Add a new user | `-m` create home dir, `-s` shell |
| `sudo passwd <user>` | Set user password | — |
| `sudo userdel <user>` | Delete user | `-r` delete home directory |
| `sudo groupadd <group>` | Create group | — |
| `sudo groupdel <group>` | Delete group | — |
| `id <user>` | View UID, GID, groups | — |
| `usermod -aG <group> <user>` | Add user to group | `-a` append, `-G` group list |

---

## 📁 Directory & File Management
| Command | Description | Flags |
|--------|-------------|--------|
| `touch <file>` | Create empty file | — |
| `vi <file>` | Open file in vi editor | — |
| `cat <file>` | Show file content | — |
| `cp <src> <dest>` | Copy file/directory | `-r` recursive, `-i` prompt |
| `mv <src> <dest>` | Move/rename | `-i` prompt |
| `rm <file>` | Remove file | `-r` recursive, `-f` force |
| `mkdir <dir>` | Create directory | `-p` create parent dirs |
| `ls` | List files | `-l` long format, `-a` hidden files, `-h` human readable |

---

## 📝 File Content & Processing
| Command | Description | Flags |
|--------|-------------|-------|
| `grep <word> <file>` | Search in file | `-i` ignore case, `-n` line num, `-r` recursive |
| `sort <file>` | Sort file content | `-r` reverse, `-n` numeric, `-f` ignore case |
| `uniq <file>` | Remove duplicate lines | `-c` count duplicates |
| `chown <user> <file>` | Change owner | `user:group` for both |
| `chmod <perm> <file>` | Change permission | Example: `chmod 777 file` |
| `lsof` | List open files | `-i` network files, `-u <user>` |
| `tar -cvf file.tar <src>` | Create tar archive | `-c` create, `-v` verbose |
| `tar -xvf file.tar` | Extract tar | `-x` extract |
| `head <file>` | First 10 lines | `-n` number of lines |
| `tail <file>` | Last 10 lines | `-f` live follow |

---

## 🖥️ System Management
| Command | Description | Flags |
|--------|-------------|--------|
| `systemctl start <service>` | Start service | — |
| `systemctl stop <service>` | Stop service | — |
| `systemctl restart <service>` | Restart service | — |
| `systemctl status <service>` | Service status | — |
| `systemctl enable <service>` | Enable at boot | — |
| `journalctl -u <service>` | View service logs | `-f` follow logs |
| `top` | Real-time processes | — |
| `ps aux` | List all processes | `--sort=-%cpu` sort |
| `kill <pid>` | Kill process | `-9` force kill |
| `df -h` | Disk usage | `-h` human readable |
| `free -h` | Memory usage | — |

---

## 🌐 Networking Commands
| Command | Description | Important Flags |
|--------|-------------|----------------|
| `ssh user@host` | Connect to remote machine | `-i` identity file, `-p` port |
| `ssh-keygen` | Generate SSH keys | `-t rsa` key type |
| `scp <src> <dest>` | Secure copy between systems | `-r` recursive |
| `ifconfig` | View network interfaces | `-a` all, `-s` short |
| `ip` | Modern network configuration tool | `ip a` addresses, `ip r` routes |
| `netstat` | Show open ports & connections | `-a` all, `-t` TCP, `-u` UDP |
| `nslookup <domain>` | DNS lookup | — |
| `ping <host>` | Test network connectivity | `-c` packet count |
| `curl <url>` | Transfer data | `-I` headers, `-O` output file |
| `wget <url>` | Download files | `-c` resume download |
| `iptables` | Configure Linux firewall | `-L` list rules, `-F` flush |

## 🛠️ Miscellaneous Commands
| Command           | Description                        |
| ----------------- | ---------------------------------- |
| `awk`             | Pattern scanning & data processing |
| `sed`             | Stream editor for text replacement |
| `which <command>` | Show path of command               |
| `uptime`          | Show system uptime                 |
| `hostname`        | Show system hostname               |
| `reboot`          | Restart system                     |
