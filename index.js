const http = require("http");
const port = 3000;
const server = http.createServer((req, res) => {
  switch (req.url.toLowerCase()) {
    case "/date":
      res.write(new Date().toJSON());
      break;
    case "/hello":
      res.write("Hello World v1.0");
      break;
    default:
      res.writeHeader(200, { "Content-Type": "text/html" });
      res.write(`Date: <a href='./date'>date</a><br/>
      Hello World: <a href='./hello'>date</a>`);
      break;
  }
  res.end();
});

server.listen(port, () => {
  console.log("application hosted", "http://localhost:3000/");
});
