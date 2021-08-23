using UnityEngine;

namespace Swipes
{
    public class SwipeDrawer : MonoBehaviour
    {
        private LineRenderer _lineRenderer;

        private float _zOffset = 10;

        private void Awake()
        {
            _lineRenderer = GetComponent<LineRenderer>();
            SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
        }

        private void SwipeDetector_OnSwipe(SwipeData data)
        {
            Vector3[] positions = new Vector3[2];
            positions[0] = Camera.main.ScreenToWorldPoint(new Vector3(data.StartPosition.x, data.StartPosition.y, _zOffset));
            positions[1] = Camera.main.ScreenToWorldPoint(new Vector3(data.EndPosition.x, data.EndPosition.y, _zOffset));
            _lineRenderer.positionCount = 2;
            _lineRenderer.SetPositions(positions);
        }
    }
}