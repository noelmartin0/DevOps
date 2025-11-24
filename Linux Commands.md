# Linux for DevOps

## Basic commands
| Commands  | Description |
| -------------        |:-------------:|
| man command_name     | To know about any linux command     |
| clear                | Clears terminal     |
| pwd                  | Present working directory     |
| echo "value"         | To print any string value |
| whoami               | To know about current user |
| su username          | To switch user     |

## User Management
| Commands  | Description |
| -------------        |:-------------:|
| sudo bash            | To switch rootuser         |
| sudo useradd username| To add new user            |
| sudo passwd username | To add password to user    |
| sudo userdel username| To delete a user          |
| sudo groupadd groupname| To add a group           |
| sudo groupdel groupname| To delete a group        |

## Directory Management
| Commands  | Description |
| -------------        |:-------------:|
| touch filename       | To create a file           |
| vi filename          | To open vi editor          |
| cat filename         | To display the file        |
| cp [flag] filename dest_path| To copy file to destination path|
| mv [flag] filename dest_path| To move file to destination path|
| rm [flag] filename          | Remove file in current directory |
| mkdir [flag] path/dir | Create directory(s) to specified path |
| rmidr [flag] dirname  | Delete an empty directory |

## File content management
| Commands  | Description | Flags |
| -------------        |-------------|:-------------:|
| grep [flag] word filename | To fine word in the file |
| sort [flag] filename | To sort the words in the file | -r reverse, -f case-insentivie, -n num order |
|chown username filename | Change ownership of the file |
|chmod permission filename | Change permission of the file eg: chmod 777 filename.txt full access |
| lsof | List of files that are opened |
| lsof -u username | List of files opened by the user |




