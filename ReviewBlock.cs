public class ReviewBlock {
    private readonly Catalog _catalog;
    private readonly List<Review> _review = new List<Review>();

    public ReviewBlock(Catalog catalog) {
        _catalog = catalog;
    }

    public bool AddReview(Review review) {
        if (FindReview(review.Id) != null) {
            return false;
        }
        _review.Add(review);
        return true;
    }

    public Review? FindReview(int review_Id) {
        foreach (Review review in _review) {
            if (review.Id == review_Id) {
                return review;
            }
        }
        return null;
    }

    public bool TryAssign(int review_Id, string gameName) {
    Review? review = FindReview(review_Id);
    if (review == null) {
        return false;
    }

    Game? game = _catalog.FindGame(gameName);
    if (game == null) {
        return false;
    }

    return review.TryAssign(game);
}

public bool TryWin(int review_Id) {
    Review? review = FindReview(review_Id);
    if (review == null) {
        return false;
    }
    return review.TryWin();
}
}

