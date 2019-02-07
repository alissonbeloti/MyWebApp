export class Produto {
    public id: number = 0
    private _nome: string

    constructor(private sigla: string, private preco: number) {

    }
    public exibirSigla() {
        alert(this.sigla)
    }
    public obterNome(): string {
        return this.nome
    }
    public obterId(): number {
        return this.id
    }

    get nome() {
        return this._nome;
    }
    set nome(val) {
        this._nome = val
    }
}

//let produto = new Produto()