//https://www.youtube.com/watch?v=5ElKFY3N1zs

#define SW 8 //joystick data
#define joy_x A0 //joystick X position
#define joy_y A3 //joystick y position

void setup(){
  Serial.begin(19200);
  pinMode(sw, INPUT_PULLUP);
  pinMode(joy_x, INPUT);
  pinMode(joy_y, INPUT);
}

void loop(){
  float joy_rx = analogRead(joy_x);
  float joy_ry = analogRead(joy_y);

  joy_rx = map(joy_rx, 1, 1024, -500, 500);
  joy_ry = map(joy_ry, 1, 1024, -500, 500);

  Serial.print(joy_rx);
  Serial.print(" , ");
  Serial.print(joy_ry);
  Serial.print(" , ");
  Serial.println(!digitalRead(SW));
}
