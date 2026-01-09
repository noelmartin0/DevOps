## YAML in Kubernetes
---
#### Pods with YAML
```
apiVersion:
kind:
metadata:


specs:
```

| Kind| Version |
|--------|------|
| Pod | v1 |
|Service | v1|
|ReplicaSet| apps/v1 |
|Deployment | apps/v1 |

##### Example
```
# filename pod-definition.yml
apiVersion: v1
kind: pod
metadata:
  name: myapp-prod
  labels:
     app: myapp
     type: front-end
specs:
  containers:
   - name: nginx-container
     image: nginx  
```

##### Command
```
kubectl create -f pod-definition.yml
```
