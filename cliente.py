import http.client as client

tanque = 0
tempo = 
conex = client.HTTPSConnection("localhost")

def comum():
    conex = client.HTTPSConnection("localhost")
    conex.request("GET","/")
    tanque = tanque + (conex.text.toString)
    resposta = conex.getresponse()
    print("Status:{} and reason:{}".format(resposta.status, resposta.reason))

    conex.close()

while 1<0
    timer.sleep(tempo)
    comum()
end
