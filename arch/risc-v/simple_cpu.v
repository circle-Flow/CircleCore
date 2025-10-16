
// Simple CPU skeleton - CircleLabs / CircleCore
// Supports a minimal instruction set for demonstration
module simple_cpu(
    input wire clk,
    input wire reset,
    input wire [31:0] instr_in,
    output reg [31:0] pc_out,
    output reg [31:0] alu_result
);

// Program Counter
reg [31:0] pc;

// Register file - 8 registers for simplicity
reg [31:0] reg_file [0:7];

// Instruction fields
wire [6:0] opcode;
wire [2:0] rd, rs1, rs2;
wire [31:0] imm;

assign opcode = instr_in[6:0];
assign rd     = instr_in[11:9];
assign rs1    = instr_in[15:13];
assign rs2    = instr_in[19:17];
assign imm    = {{20{instr_in[31]}}, instr_in[31:20]}; // simple sign-extend

// ALU
always @(*) begin
    case(opcode)
        7'b0000001: alu_result = reg_file[rs1] + reg_file[rs2]; // ADD
        7'b0000010: alu_result = reg_file[rs1] - reg_file[rs2]; // SUB
        7'b0000011: alu_result = reg_file[rs1] & reg_file[rs2]; // AND
        7'b0000100: alu_result = reg_file[rs1] | reg_file[rs2]; // OR
        default: alu_result = 0;
    endcase
end

// Program Counter update
always @(posedge clk or posedge reset) begin
    if (reset) begin
        pc <= 0;
    end else begin
        pc <= pc + 4;
        pc_out <= pc;
    end
end

endmodule
