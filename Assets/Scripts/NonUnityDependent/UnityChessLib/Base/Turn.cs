﻿namespace UnityChess {
	public struct Turn {
		public readonly Piece Piece;
		public readonly Movement Move;
		public readonly bool CapturedPiece;
		public readonly bool CausedCheck;
		public readonly bool CausedStalemate;
		public readonly bool CausedCheckmate;

		public Turn(Piece piece, Movement move, bool capturedPiece, bool causedCheck, bool causedStalemate, bool causedCheckmate) {
			Piece = piece;
			Move = move;
			CapturedPiece = capturedPiece;
			CausedCheck = causedCheck;
			CausedCheckmate = causedCheckmate;
			CausedStalemate = causedStalemate;
		}
	}
}
