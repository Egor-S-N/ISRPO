# для видеокамеры 
import cv2 

face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_alt2.xml')
capture = cv2.VideoCapture(0)
while(True):
    ret, image = capture.read()
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, 1.1, 4)
    for (x, y, w, h) in faces:
        cv2.rectangle(image, (x, y), (x+w, y+h), (255, 0, 0), 2)
    cv2.imshow('Carmer', image)
    if cv2.waitKey (1) == ord ('q'): # нажмите Q для выхода
        break





#Для фотографии
import cv2 

face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_alt2.xml')
image = cv2.imread('face.jpg')
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
face = face_cascade.detectMultiScale(gray, 1.5, 5)

for (x,y,w,h) in face:
    cv2.rectangle(image, (x,y), (x+w,y+h), (0,255,0), 3)
cv2.imshow("image", image)
cv2.waitKey(0)  
cv2.destroyAllWindows()