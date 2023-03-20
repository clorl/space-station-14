if (process.argv.length < 4) {
    console.log("useage: node test {docfxJsPreprocessor} {rawModel}");
    process.exit();
}
var script = require('./' + process.argv[2]);
var fs = require('fs');
var json = JSON.parse(fs.readFileSync(process.argv[3]));
console.log("start transform");
var result = script.transform(json)
console.log("finish transform");
fs.writeFileSync("output.json", JSON.stringify(result));
console.log("finish write result to output.json");
