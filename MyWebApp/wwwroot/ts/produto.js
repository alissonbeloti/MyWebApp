var Produto = /** @class */ (function () {
    function Produto(sigla, preco) {
        this.sigla = sigla;
        this.preco = preco;
        this.id = 0;
    }
    Produto.prototype.exibirSigla = function () {
        alert(this.sigla);
    };
    Produto.prototype.obterNome = function () {
        return this.nome;
    };
    Produto.prototype.obterId = function () {
        return this.id;
    };
    Object.defineProperty(Produto.prototype, "nome", {
        get: function () {
            return this._nome;
        },
        set: function (val) {
            this._nome = val;
        },
        enumerable: true,
        configurable: true
    });
    return Produto;
}());
//let produto = new Produto()
//# sourceMappingURL=produto.js.map