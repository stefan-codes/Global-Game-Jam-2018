void setup() {
  pinMode(A4, INPUT);
  Serial.begin(9600);
}

void loop() {
  Serial.println(analogRead(A4));

  if(analogRead(A4) > 0 && analogRead(A4) < 50){
    Serial.write(analogRead(A4));
    Serial.flush();
    delay(500);
  } else {
    delay(500);
  }

}
