````md
# Kubernetes
---

## Pods
___

### What is a Pod?
A **Pod** is the smallest deployable unit in Kubernetes.  
It usually contains one container, but can run multiple tightly coupled containers that share:
- Network (same IP & port space)
- Storage volumes
- Lifecycle

Pods are **ephemeral**. If a Pod dies, it is not automatically recreated unless managed by a controller like ReplicaSet or Deployment.

---

### Pods with YAML
```yaml
apiVersion:
kind:
metadata:
spec:
````

| Kind       | Version |
| ---------- | ------- |
| Pod        | v1      |
| Service    | v1      |
| ReplicaSet | apps/v1 |
| Deployment | apps/v1 |

---

### Example

```yaml
# filename: pod-definition.yml
apiVersion: v1
kind: Pod
metadata:
  name: myapp-prod
  labels:
    app: myapp
    type: front-end
spec:
  containers:
    - name: nginx-container
      image: nginx
```

---

### Pod Commands

```bash
kubectl create -f pod-definition.yml
kubectl get pods
kubectl describe pod <pod-name>
kubectl logs <pod-name>
kubectl exec -it <pod-name> -- /bin/sh
kubectl delete pod <pod-name>
```

---

# ReplicaSet (RS)

### What is ReplicaSet?

A **ReplicaSet** ensures that a specified number of Pod replicas are always running.

If a Pod crashes, ReplicaSet automatically creates a new one.

Mostly managed by a Deployment in production.

---

### ReplicaSet with YAML

```yaml
apiVersion:
kind:
metadata:
spec:
  replicas:
  selector:
    matchLabels:
  template:
    metadata:
      labels:
    spec:
      containers:
```

---

## Kubernetes ReplicaSet – Important Commands

### Create & Apply

```bash
kubectl apply -f replicaset.yaml
kubectl create -f replicaset.yaml
```

### View & Inspect

```bash
kubectl get rs
kubectl get rs -o wide
kubectl describe rs <replicaset-name>
kubectl get rs <replicaset-name> -o yaml
```

### Pods Managed by ReplicaSet

```bash
kubectl get pods --show-labels
kubectl describe pod <pod-name>
```

### Scaling

```bash
kubectl scale rs <replicaset-name> --replicas=5
kubectl edit rs <replicaset-name>
```

### Delete

```bash
kubectl delete rs <replicaset-name>
kubectl delete rs <replicaset-name> --cascade=foreground
kubectl delete -f replicaset.yaml
```

---

# Deployment

## What is Deployment?

A **Deployment** manages ReplicaSets and provides:

* Rolling updates
* Rollbacks
* Version history
* Zero downtime deployment
* Easy scaling

When updating an image version, Deployment creates a new ReplicaSet and gradually replaces old Pods.

Deployment is the most commonly used controller in Kubernetes.

---

## Deployment YAML Structure

```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: myapp-deployment
spec:
  replicas: 3
  selector:
    matchLabels:
      app: myapp
  template:
    metadata:
      labels:
        app: myapp
    spec:
      containers:
        - name: nginx
          image: nginx:1.25
```

---

## Important Deployment Commands

### Create & Apply

```bash
kubectl apply -f deployment.yaml
kubectl create -f deployment.yaml
```

### View

```bash
kubectl get deploy
kubectl describe deploy <deployment-name>
kubectl get deploy <deployment-name> -o yaml
```

### Scaling

```bash
kubectl scale deploy <deployment-name> --replicas=5
```

### Rolling Updates

```bash
kubectl set image deploy <deployment-name> nginx=nginx:1.26
kubectl rollout status deploy <deployment-name>
kubectl rollout history deploy <deployment-name>
```

### Rollback

```bash
kubectl rollout undo deploy <deployment-name>
kubectl rollout undo deploy <deployment-name> --to-revision=2
```

### Delete

```bash
kubectl delete deploy <deployment-name>
```

---

# Deployment vs ReplicaSet

| Feature                 | ReplicaSet | Deployment  |
| ----------------------- | ---------- | ----------- |
| Maintains replica count | Yes        | Yes         |
| Rolling updates         | No         | Yes         |
| Rollback support        | No         | Yes         |
| Version history         | No         | Yes         |
| Manages ReplicaSets     | No         | Yes         |
| Production usage        | Rare       | Very Common |

**Deployment = Advanced ReplicaSet**

---

# HPA (Horizontal Pod Autoscaler)

## What is HPA?

HPA automatically scales Pods based on:

* CPU utilization
* Memory usage
* Custom metrics

Example:

* CPU > 70% → scale up
* CPU < 30% → scale down

---

## HPA Commands

```bash
kubectl autoscale deployment <deployment-name> --cpu-percent=70 --min=2 --max=10
kubectl get hpa
kubectl describe hpa <hpa-name>
```

---

# KEDA (Kubernetes Event Driven Autoscaling)

KEDA is an event-driven autoscaler.

Unlike HPA (CPU/Memory based), KEDA scales based on:

* Kafka
* Azure Service Bus
* RabbitMQ
* Prometheus
* HTTP requests
* Cron schedules

KEDA can scale workloads to **zero**.

---

## ScaledObject (KEDA)

ScaledObject is a Custom Resource Definition used by KEDA.

It defines:

* Target Deployment
* Trigger type
* Scaling rules
* Min/Max replicas

Example triggers:

* Queue length
* Message count
* HTTP request rate
* Cron schedule

---

# Kubernetes Services

Service provides stable network access to Pods.

Pods have dynamic IP addresses. Service provides a stable endpoint.

---

## ClusterIP (Default)

* Internal communication only
* Accessible inside cluster

```yaml
type: ClusterIP
```

---

## NodePort

* Exposes service on Node IP
* Accessible externally
* Port range: 30000–32767

```yaml
type: NodePort
```

Access:

```
http://NodeIP:NodePort
```

---

## LoadBalancer

* Used in cloud environments
* Provisions external cloud load balancer
* Provides public IP

```yaml
type: LoadBalancer
```

---

## Headless Service

```yaml
clusterIP: None
```

* No load balancing
* Used with StatefulSets
* Each Pod gets DNS entry

---

# Other Important Concepts

## Namespace

Logical isolation inside cluster.

```bash
kubectl get ns
kubectl create ns dev
```

---

## ConfigMap

Stores non-sensitive configuration data.

---

## Secret

Stores sensitive data like passwords and tokens.

---

## Ingress

Manages external HTTP/HTTPS access.

* Path-based routing
* Requires Ingress Controller

---

# Architecture Flow

Client
→ Ingress
→ Service
→ Deployment
→ ReplicaSet
→ Pod
→ Container

Autoscaling:

* Metrics-based → HPA
* Event-based → KEDA

```
```
