# 🎯 Sharp Shooter

**Sharp Shooter** is a fast-paced 3D first-person shooter built in Unity where precision meets chaos. Navigate through custom-built environments, engage diverse enemy types, and survive waves of combat using an arsenal of customizable weapons.

---

## 📜 Game Overview

Enter the arena as a lone gunner facing relentless waves of mechanical enemies. From ground-based assault units to stationary turrets and explosive threats, each enemy type demands different tactical approaches. Master your weapon handling, manage your ammunition wisely, and survive the onslaught to achieve victory.

---

## 🚀 Key Features

### ⚔️ Dynamic Combat System
- Weapon switching with unique characteristics per firearm  
- Ammunition management with pickup mechanics  
- Zoom functionality for precision shooting  

### 🤖 Diverse Enemy Arsenal
- Aggressive melee units with pathfinding AI  
- Ranged turrets with player tracking  
- Explosive threats with area-of-effect damage  
- Continuous enemy spawning system  

### 🕹️ Immersive First-Person Experience
- Smooth camera controls with recoil feedback  
- Visual effects for muzzle flashes and impact hits  
- Health system with intuitive UI representation  

---

## 🏗️ Architecture & Design Patterns

- **Template Method Pattern** – Abstract base classes define common behavior while allowing specialized implementations  
- **Strategy Pattern** – Weapon configurations and enemy behaviors encapsulated in modular, swappable components  
- **Observer Pattern** – Decoupled health management and game state tracking through event-driven communication  
- **Factory Pattern** – Consistent object instantiation for projectiles, effects, and enemy spawns  
- **Component-Based Design** – Modular functionality distributed across focused, reusable components  

---

## 🛠️ Programming Principles

- **SOLID Principles** – Single responsibility components with interface-based abstractions and dependency inversion  
- **DRY Implementation** – Shared base classes eliminate code duplication across similar systems  
- **Encapsulation** – Protected internal states with controlled public interfaces  
- **Composition Over Inheritance** – Flexible behavior assembly through component composition  
- **Data-Driven Design** – External configuration through ScriptableObjects for weapons and game parameters  

---

## 🎮 Unity Integration

- **ProBuilder** – Custom level geometry created entirely with Unity’s ProBuilder for rapid prototyping and iteration  
- **Cinemachine** –  
  - Smooth player following with impulse-based recoil effects  
  - Dynamic FOV adjustments for zoom mechanics  
- **NavMesh AI** – Intelligent enemy pathfinding for realistic movement  
- **Particle Systems** – Rich visual feedback for weapon effects and environment interactions  
- **ScriptableObject Architecture** – Data-driven weapon configurations for easy balancing and expansion  
- **Coroutine-Based Timing** – Non-blocking enemy spawning and weapon cooldown handling  

---

## ⚡ Performance & Polish

- **Efficient Raycasting** – Optimized hit detection using proper layers and distance checks  
- **Memory Management** – Object lifecycle managed via pooling and clean-up systems  
- **Visual Polish** – Particle effects, UI animations, and responsive feedback systems for immersive gameplay  

---

## Play Link


[![Gameplay Video](https://img.youtube.com/vi/-uoUsUf0m28/maxresdefault.jpg)](https://youtu.be/-uoUsUf0m28)
### [Watch this video on YouTube](https://youtu.be/-uoUsUf0m28)
