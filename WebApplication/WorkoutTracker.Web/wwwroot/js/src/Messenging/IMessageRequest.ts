export default abstract class IMessageRequest {
	abstract Route: string;
	abstract BuildMessage(): string;
	abstract Verb: string;
}