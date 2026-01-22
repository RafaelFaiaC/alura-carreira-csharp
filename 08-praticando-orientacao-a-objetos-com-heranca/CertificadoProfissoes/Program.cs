//Você está desenvolvendo um sistema para uma instituição que emite certificados de validação profissional. Cada profissão cadastrada precisa ser reconhecida como um tipo válido, mas a entidade base (Profissão) não deve ser instanciada diretamente, pois representa apenas um conceito abstrato.

//Crie um programa que:
//Defina uma classe abstrata Profissao com um atributo titulo.
//Crie duas classes que herdem de Profissao:
//Analista: deve receber o título via construtor.
//Docente: deve receber o título via construtor.
//Implemente uma classe Certificado que:
//Aceite qualquer objeto do tipo Profissao em seu construtor.
//Exiba a mensagem formatada: "Certificado emitido para: <titulo>".

//Exemplo de entrada:
//Analista analista = new Analista("Analista de Sistemas");
//Docente docente = new Docente("Docente de Matemática");
//Certificado cerf1 = new Certificado(analista);
//Certificado certf2 = new Certificado(docente);

//Saída esperada:
//Certificado emitido para: Analista de Sistemas
//Certificado emitido para: Docente de Matemática

Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matemática");
Certificado cerf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);