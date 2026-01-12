# Kubernetes
---
##  Pods 
___
##### Pods with YAML
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

##### Pod Command
```
kubectl create -f pod-definition.yml
kubectl get pods
```
---
## ReplicaSet
##### ReplicaSet with YAML
```
apiVersion:
kind:
metadata:


specs:
  template:
    # pod template
  replicas:
  selector:
    matchedLabels:
```
## Kubernetes ReplicaSet – Important Commands

#### Create & Apply
- `kubectl apply -f replicaset.yaml` — Create or update a ReplicaSet from a YAML file.
- `kubectl create -f replicaset.yaml` — Create a ReplicaSet (fails if it already exists).

#### View & Inspect
- `kubectl get rs` — List all ReplicaSets in the current namespace.
- `kubectl get rs -o wide` — Show ReplicaSets with additional details.
- `kubectl describe rs <replicaset-name>` — Display detailed information and events of a ReplicaSet.
- `kubectl get rs <replicaset-name> -o yaml` — View the ReplicaSet configuration in YAML format.

#### Pods Managed by ReplicaSet
- `kubectl get pods --show-labels` — List Pods and their labels to see which belong to a ReplicaSet.
- `kubectl describe pod <pod-name>` — Check which ReplicaSet controls a Pod.

#### Scaling
- `kubectl scale rs <replicaset-name> --replicas=5` — Scale the ReplicaSet to 5 Pods.
- `kubectl edit rs <replicaset-name>` — Edit the ReplicaSet live (e.g., change replicas count).

#### Updates & Rollbacks
- `kubectl replace -f replicaset.yaml` — Replace an existing ReplicaSet configuration.
- `kubectl rollout history rs <replicaset-name>` — View rollout history (limited support for ReplicaSets).

#### Delete & Cleanup
- `kubectl delete rs <replicaset-name>` — Delete the ReplicaSet but keep Pods (default behavior).
- `kubectl delete rs <replicaset-name> --cascade=foreground` — Delete ReplicaSet and all its Pods.
- `kubectl delete -f replicaset.yaml` — Delete ReplicaSet defined in a YAML file.

#### Debugging
- `kubectl logs <pod-name>` — View logs of a Pod created by the ReplicaSet.
- `kubectl exec -it <pod-name> -- /bin/sh` — Access a running Pod shell.
