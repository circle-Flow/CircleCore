# CircleCore
CircleCore is an ambitious open-source initiative by CircleLabs designed to disrupt the global chip industry by enabling anyone with a laptop and internet to contribute to building the next generation of ultra-fast, AI-optimized processors. In a world dominated by giants like Intel and NVIDIA, CircleCore aims to democratize access to chip design, development, and testing through a collaborative and transparent ecosystem.

The core mission of CircleCore is simple yet bold: to create a high-performance, modular, and open silicon architecture capable of rivaling today’s most powerful processors. Unlike traditional chip development, which requires billion-dollar fabs and closed IP, CircleCore focuses on a software-first approach — leveraging open hardware description languages, simulated chip architectures, and modular driver stacks to accelerate innovation at unprecedented speed.

Our architecture prioritizes parallelism, AI workload optimization, and energy efficiency. Through community-driven R&D, contributors can design new cores, optimize instruction pipelines, build low-level drivers in Rust/C++, and run real-time performance simulations using open-source EDA (Electronic Design Automation) tools. The project will provide templates, SDKs, and well-documented workflows to make contributing accessible even to individual developers and small teams.

CircleCore’s strategy is to bridge chip innovation and open collaboration, fostering a network of contributors building custom processing units designed for AI, ML, edge computing, and high-throughput applications. Instead of replicating existing architectures, we aim to leap forward — experimenting with novel memory hierarchies, lightweight instruction sets, and intelligent power scaling.

By combining distributed development with global brainpower, CircleCore seeks to lower entry barriers to chip innovation. Just as open-source software transformed the internet, CircleCore envisions a world where open silicon accelerates breakthroughs in AI and computing. With strong technical foundations, fast feedback loops, and global participation, CircleCore is not just a chip project — it’s the foundation of a new open hardware revolution.

This is how we build the future: one core, one line of code, and one contributor at a time.


🪐 CircleLabs / CircleCore

> "The next Intel or NVIDIA won’t be a corporation — it’ll be a community."

CircleCore is an **open-source, high-performance chip architecture project** by **CircleLabs**.  
We aim to democratize chip innovation by creating a **RISC-V-based processor** optimized for AI, ML, and high-throughput workloads. Contributors worldwide can design, simulate, and test next-gen chips — all in the open.

---

## 🚀 Why CircleCore

The chip industry has long been dominated by a few corporations. CircleCore changes that by:

- 💻 Making **chip design open and accessible**  
- 🌍 Enabling **global collaboration** for hardware innovation  
- ⚡ Building **high-performance, modular, and AI-optimized cores**  

Our long-term vision is to **rival top-tier processors** like Intel Core i9 and NVIDIA H100 in specific workloads using open-source tools and community power.

---

## 🧭 Project Structure


---

## 🧰 Tech Stack

- **ISA:** RISC-V  
- **Simulation:** Verilator, Gem5, QEMU  
- **Driver Stack:** Linux kernel modules in C/Rust  
- **Firmware:** Coreboot / Libreboot  
- **OS:** Minimal Linux via Buildroot / Yocto  
- **Languages:** Verilog, SystemVerilog, C, Python  

---

## 🧑‍💻 Quick Start

### 1. Clone the repo
```bash
git clone https://github.com/circlelabs-ai/circlecore.git
cd circlecore

2. Install dependencies
bash
sudo apt update
sudo apt install make gcc g++ python3 verilator qemu-system riscv-gnu-toolchain

3. Build and run simulation
bash
cd sim
make run
4. Boot minimal Linux
bash
make linux

🤝 Contributing
CircleCore welcomes:
RTL/Verilog designers
Kernel/driver developers
Testers and benchmarkers
Documentation writers
Community organizers

Check CONTRIBUTING.md to learn how to contribute.

🧪 Roadmap
Phase	Goal	ETA
1	Minimal RISC-V core + Linux boot	In progress
2	Multi-core + cache system	Month 3
3	Driver stack for I/O + memory	Month 5
4	Benchmark vs i9 in simulation	Month 8
5	FPGA prototype	Month 12
6	Optional silicon tapeout	Month 18+

🧪 Testing & Benchmarking
Phoronix Test Suite for performance
SPEC CPU workloads
Linux perf tools for latency, interrupts, and memory throughput
Unit tests for drivers
bash
cd tests
make run
🌍 Community
💬 Discord — Developer chat

🛠️ GitHub Projects — Roadmap & sprints

🪙 Sponsor — Fund FPGA & fab milestones

📜 License
Apache 2.0 — free to use, fork, and modify.

✨ Team & Contributors
CircleLabs Core	Engineering	Simulation & RTL
Community	❤️	Collaboration & Testing

⭐ Star the Project
If you’re excited about open silicon, star ⭐ the repo and join the revolution.
CircleCore is more than a chip — it’s a movement.
