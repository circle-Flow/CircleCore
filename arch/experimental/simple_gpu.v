// Simple GPU compute unit skeleton
module simple_gpu(
    input wire clk,
    input wire reset,
    input wire start,
    input wire [31:0] data_in,
    output reg [31:0] data_out,
    output reg done
);

// 4-lane SIMD unit
reg [31:0] lane [0:3];

integer i;

always @(posedge clk or posedge reset) begin
    if(reset) begin
        done <= 0;
        for(i=0;i<4;i=i+1) lane[i] <= 0;
    end else if(start) begin
        // simple operation: multiply each lane by 2
        for(i=0;i<4;i=i+1)
            lane[i] <= data_in * (i+1) * 2;
        data_out <= lane[0] + lane[1] + lane[2] + lane[3];
        done <= 1;
    end else begin
        done <= 0;
    end
end

endmodule
