#version 330 core
layout (location = 0) in vec3 aPosition;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    float X = aPosition.x;
    float Y = aPosition.y;
    float Z = aPosition.z;
    
    vec3 Position;
    Position.x = X * sqrt(1 - (Y*Y + Z*Z)/2 + (Y*Y*Z*Z)/3);
    Position.y = Y * sqrt(1 - (X*X + Z*Z)/2 + (X*X*Z*Z)/3);
    Position.z = Z * sqrt(1 - (X*X + Y*Y)/2 + (X*X*Y*Y)/3);
    
    gl_Position = projection * view * model * vec4(Position, 1.0f);
}