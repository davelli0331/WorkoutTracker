import { Router } from "../Utilities/Router";
import IMessageRequest from "./IMessageRequest";

export namespace Messenger {
	class MessageCallback {
		MessageType: IMessageRequest;
		Callback: (response: any) => void;
	}

	var callBacks = new Array<MessageCallback>();

	function processResponse(request: IMessageRequest, response: any) {
		callBacks.forEach(messageCallback => {
			if (messageCallback.MessageType == request) {
				messageCallback
			}
		});
	}

	export function Register(messageType: IMessageRequest, callback: (response: any) => void): void {
		var messageCallback = new MessageCallback();
		messageCallback.MessageType = messageType;
		messageCallback.Callback = callback;

		callBacks.push(messageCallback);
	}

	export function UnRegister(messageType: IMessageRequest, callback: (response: any) => void): void {

	}

	export function Send(request: IMessageRequest): void {
		switch (request.Verb) {
			case "POST":
				Router.Post(request.Route, request.BuildMessage(), (response) => {

				});
				break;
		}
	}
}